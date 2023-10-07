using BankApp.Entities;
using BankApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BankApp.Repository.FileImplementation
{
    public class FileRepositoryBase<T> : IRepository<T> where T : IEntityWithUUID
    {
        private const string _initialPath = "Repository";

        public virtual T Add(T entity)
        {
            //if (!Directory.Exists(_initialPath))
            //    Directory.CreateDirectory(_initialPath);

            string entityFolderPath = Path.Combine(_initialPath, typeof(T).Name);

            //if (!Directory.Exists(entityFolderPath))
            //    Directory.CreateDirectory(entityFolderPath);

            if (entity.UUID == Guid.Empty)
                entity.UUID = Guid.NewGuid();


            string filePath = Path.Combine(entityFolderPath, $"{entity.UUID.ToString("N")}.json");

            FileInfo fileInfo = new FileInfo(filePath);

            fileInfo.Directory?.Create();

            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, entity);
            }

            return entity;
        }

        public virtual void Delete(Guid uuid)
        {
            string entityFolderPath = Path.Combine(_initialPath, typeof(T).Name, $"{uuid.ToString("N")}.json");

            File.Delete(entityFolderPath);
        }

        public virtual IEnumerable<T> GetAll()
        {
            string entityFolderPath = Path.Combine(_initialPath, typeof(T).Name);

            List<string> fileNames = Directory.GetFiles(entityFolderPath).ToList();
            foreach (string fileName in fileNames)
            {
                
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    string text = streamReader.ReadToEnd();

                    T entity = JsonConvert.DeserializeObject<T>(text);

                    yield return entity;
                }
            }
        }

        public virtual T Update(T entity)
        {
            Delete(entity.UUID);

            T newEntity = Add(entity);

            return newEntity;
        }
    }
}

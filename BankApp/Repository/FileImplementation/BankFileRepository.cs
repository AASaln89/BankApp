using BankApp.Entities;
using BankApp.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankApp.Repository.FileImplementation
{
    public class BankFileRepository : FileRepositoryBase<Bank>, IBankRepository
    {

    }
}

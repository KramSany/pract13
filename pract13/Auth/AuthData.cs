using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pract13.Auth
{
    public class AuthData
    {
        private Dictionary<string, string> _authenticationData = new();
        public AuthData()
        {
            Load();
            
        }
        public bool AddUser(string login, string password)
        {
            if (_authenticationData.ContainsKey(login))
            {
                return false;
            }
            _authenticationData.Add(login, password);
            Save();
            return true;
        }
        public bool Authorization (string login, string password)
        {
            if (!_authenticationData.TryGetValue(login, out string result))
            {
                return false;
            }
            if (result != password)
            {
                return false;
            }
            return true;
        }
        private void Save ()
        {
            string json = JsonConvert.SerializeObject(_authenticationData, Formatting.Indented);
            File.WriteAllText(@"authenticationData.json", json);

        }
        private void Load ()
        {
            if (!File.Exists(@"authenticationData.json"))
            {
                return;
            }
            string json = File.ReadAllText(@"authenticationData.json");
            _authenticationData = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);
        }

    }
}

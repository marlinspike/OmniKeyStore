using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace OmniKeyStore.SecretBridge {
    public class ConfigFileImplementor : AbstractStore {
        public override async Task<string> GetSecret(string secretName) {
            string secretValue = ConfigurationManager.AppSettings[secretName].ToString();
            return secretValue;
        }


    }
}

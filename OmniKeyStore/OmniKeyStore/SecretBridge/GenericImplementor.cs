using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OmniKeyStore.SecretBridge {

    //This strategy first reads from Config; If the secret is not found, it then reads from KV; if secret is not found, returns null
    public class GenericImplementor : AbstractStore {
        
        public override async Task<string> GetSecret(string secretName) {
            //string token = KeyVaultHelper.getToken();

            SecretSource kvSource = new SecretSource(new ConfigFileImplementor());
            string value = kvSource.getSecert(secretName).GetAwaiter().GetResult();

            if(value == null) {
                kvSource = new SecretSource(new KeyVaultImplementor());
                value = kvSource.getSecert(secretName).GetAwaiter().GetResult();
            }

            return value;

        }

    }

}

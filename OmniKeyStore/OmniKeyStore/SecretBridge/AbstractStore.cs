using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OmniKeyStore.SecretBridge {
    public abstract class AbstractStore {
        public abstract Task<string> GetSecret(string secretName);
    }
}

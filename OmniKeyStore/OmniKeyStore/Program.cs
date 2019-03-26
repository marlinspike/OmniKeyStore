using OmniKeyStore.SecretBridge;
using System;

namespace OmniKeyStore {
    class Program {
        static void Main(string[] args) {
            //Get a Secret from the Key Vault Implementor
            SecretSource kvSource = new SecretSource(new KeyVaultImplementor());
            string keyVaultSecret = kvSource.getSecert("hw").GetAwaiter().GetResult();
            Console.WriteLine("Got Secret: " + keyVaultSecret);
            Console.ReadLine();
        }
    }
}

namespace BTLab04._3Cshap
{
    internal class Program
    {
        private static object plainText="hello toi la damquocdan";

        public static object key { get; private set; }

        static void Main(string[] args)
        {
            Document document = new Document();
            object data = "gg driver";
            document.Read();
            document.Write(data);
            string encryptedText = document.Encrypt(plainText,key);
            Console.WriteLine("encrypted:"+encryptedText);
            string decryptedText = document.Decrypt(encryptedText,key);
            Console.WriteLine("decrypted:" + decryptedText);


        }
    }
}
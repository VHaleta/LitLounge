namespace LitLounge.Helpers
{
    public static class Encrypter
    {
//        private static readonly string key

        public static string Encrypt(string str)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(str);
            data = System.Security.Cryptography.SHA256.HashData(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }
    }
}

using Postgrest;
using Supabase;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Management
{
    public class SupabaseManager
    {
        public Supabase.Client Client;

        private const string Url = "https://hpvdlorgdoeaooibnffe.supabase.co";

        private const string Key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImhwdmRsb3JnZG9lYW9vaWJuZmZlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODQ0MzA3ODMsImV4cCI6MjAwMDAwNjc4M30.toI_Vn6TKJFbM8YBT3qbYzLCiAfQtj9VHKw53qQNYOU";

        private readonly SupabaseOptions Options = new SupabaseOptions
        {
            AutoConnectRealtime = true
        };

        public SupabaseManager()
        {
            Client = new Supabase.Client(Url, Key, Options);
        }

<<<<<<< HEAD
<<<<<<< HEAD
                supabase = new Supabase.Client(url, key, options);
                //await supabase.InitializeAsync();
                //var session = await supabase.Auth.SignIn("duongttt8@gmail.com", "SunsilkSunshine1708");
            }

            return supabase;
=======
        public async Task Connect()
        {
            Client ??= new Supabase.Client(Url, Key, Options);
            await Client.InitializeAsync();
            await Client.Auth.SignIn("duongttt8@gmail.com", "SunsilkSunshine1708");
            IsConnected = true;
>>>>>>> 434708280cb2bed5bb7bf448544167a887325e46
=======
        public async Task Connect(string email, string password)
        {
            Client ??= new Supabase.Client(Url, Key, Options);
            await Client.InitializeAsync();
            await Client.Auth.SignIn(email, password);
>>>>>>> 6f1b6e0a95d1c79f8483809a05b0d1003b0394d9
        }
    }
}
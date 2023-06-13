using Supabase;
using System.Threading.Tasks;

namespace Pet_Management
{
    public class SupabaseManager
    {
        private static Supabase.Client supabase;

        public static async Task<Supabase.Client> GetSupabase()
        {
            if (supabase == null)
            {
                var url = "https://hpvdlorgdoeaooibnffe.supabase.co";
                var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImhwdmRsb3JnZG9lYW9vaWJuZmZlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODQ0MzA3ODMsImV4cCI6MjAwMDAwNjc4M30.toI_Vn6TKJFbM8YBT3qbYzLCiAfQtj9VHKw53qQNYOU";

                var options = new SupabaseOptions
                {
                    AutoConnectRealtime = true
                };

                supabase = new Supabase.Client(url, key, options);
                await supabase.InitializeAsync();
                var session = await supabase.Auth.SignIn("duongttt8@gmail.com", "SunsilkSunshine1708");
            }

            return supabase;
        }
    }
}
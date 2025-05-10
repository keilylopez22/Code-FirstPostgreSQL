using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace CodeFirstAPI.Services
{
    public static class FirebaseInitializer
    {
        public static void InitializeFirebase()
        {
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile("firebase-adminsdk.json")
                });
            }
        }
    }
}

using Sample.Debugging;

namespace Sample
{
    public class SampleConsts
    {
        public const string LocalizationSourceName = "Sample";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "66a2bfae62f34210813a5f406b5c3297";
    }
}

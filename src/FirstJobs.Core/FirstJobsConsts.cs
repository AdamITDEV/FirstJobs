using FirstJobs.Debugging;

namespace FirstJobs
{
    public class FirstJobsConsts
    {
        public const string LocalizationSourceName = "FirstJobs";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b6e0b980a66a46258f5ac952d8d805f6";
    }
}

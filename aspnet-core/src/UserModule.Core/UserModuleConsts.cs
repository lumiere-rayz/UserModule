using UserModule.Debugging;

namespace UserModule
{
    public class UserModuleConsts
    {
        public const string LocalizationSourceName = "UserModule";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "835065a0a2c64bfd91813709431914f3";
    }
}

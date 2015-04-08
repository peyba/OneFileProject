namespace ClassLibraryForTest
{
    /// <summary>
    /// Simple class for test OneFileProject
    /// </summary>
    public class SimpleLibClass
    {
        /// <summary>
        /// Get class version
        /// </summary>
        public static string Version
        {
            get { return "1.0.1"; }
        }
        
        /// <summary>
        /// Get or set any string data
        /// </summary>
        public string MyProperty { get; set; }
    }
}
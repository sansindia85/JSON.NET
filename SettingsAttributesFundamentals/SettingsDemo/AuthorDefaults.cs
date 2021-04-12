using System.ComponentModel;

namespace SettingsDemo
{
    class AuthorDefaults
    {
        public string name { get; set; }

        [DefaultValue(true)]
        public bool happy { get; set; }

        [DefaultValue(true)]
        public bool resting { get; set; }

        [DefaultValue(4)]
        public int courses { get; set; }

        [DefaultValue("Passionate about teaching")]
        public string state { get; set; }

    }
}

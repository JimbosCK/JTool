using System.Reflection;

namespace JTool.Entities {
    public class Settings {
        public string ConString { get; set; }
        public string ProjectDirectory { get; set; }
        public ScaffoldFlags ScaffoldFlags { get; set; }

        public Settings() {
            ConString = string.Empty;
            ProjectDirectory = string.Empty;
            ScaffoldFlags = new ScaffoldFlags();
        }

        public Settings(string conString, string projectDirectory, ScaffoldFlags scaffold) {
            ConString = conString;
            ProjectDirectory = projectDirectory;
            ScaffoldFlags = scaffold;

        }

        public override bool Equals(object obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            Settings otherSettings = (Settings)obj;

            PropertyInfo[] properties = GetType().GetProperties();

            foreach (var property in properties) {
                var value1 = property.GetValue(this);
                var value2 = property.GetValue(otherSettings);

                if (!value1.Equals(value2)) {
                    return false;
                }
            }

            return true;
        }
    }

    public class ScaffoldFlags {
        public bool NoOnConfiguring { get; set; }
        public bool Force { get; set; }
        public bool DataAnnotations { get; set; }
        public string OutputDir { get; set; }
        public string ContextDir { get; set; }

        public ScaffoldFlags() {
            NoOnConfiguring = false;
            Force = false;
            DataAnnotations = false;
            OutputDir = String.Empty;
            ContextDir = String.Empty;
        }
        public ScaffoldFlags(bool noOnConfiguring, bool force, bool dataAnnotations, string outputDir, string contectDir) {
            NoOnConfiguring = noOnConfiguring;
            Force = force;
            DataAnnotations = dataAnnotations;
            OutputDir = outputDir;
            ContextDir = contectDir;
        }

        public override bool Equals(object obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            ScaffoldFlags otjerScaffoldFlags = (ScaffoldFlags)obj;

            PropertyInfo[] properties = GetType().GetProperties();

            foreach (var property in properties) {
                var value1 = property.GetValue(this);
                var value2 = property.GetValue(otjerScaffoldFlags);

                if (!value1.Equals(value2)) {
                    return false;
                }
            }

            return true;
        }
    }
}

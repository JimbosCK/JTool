using JTool.Entities;

namespace JTool.Helpers {
    public class ScaffoldHelper {
        public Settings Settings { get; set; }
        public ScaffoldHelper() {
            Settings = new Settings();
        }
        public ScaffoldHelper(Settings settings) {
            Settings = settings;
        }
        public string BuildFlagString() {
            string flagStr = string.Empty;
            if (Settings.ScaffoldFlags.DataAnnotations) flagStr += "--data-annotations ";
            if (Settings.ScaffoldFlags.Force) flagStr += "--force ";
            if (Settings.ScaffoldFlags.NoOnConfiguring) flagStr += "--no-onconfiguring ";

            return flagStr;
        }
    }
}

using Microsoft.Build.Framework;
using Newtonsoft.Json.Linq;
using MSBuildTask = Microsoft.Build.Utilities.Task;

namespace MSBuildTasks
{
    public class SayHello : MSBuildTask
    {
        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Aloha");
            var json = new JObject();
            return true;
        }
    }
}

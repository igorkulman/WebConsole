using WebConsole.Scripting.Repositories;

namespace WebConsole.Scripting
{
    public class ScriptingContext
    {
        public DataRepository Repository;

        public ScriptingContext()
        {
            Repository = new DataRepository();
        }
    }
}

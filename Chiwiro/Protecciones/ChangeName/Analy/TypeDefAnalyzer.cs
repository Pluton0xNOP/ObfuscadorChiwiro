namespace Chiwiro.Protecciones.ChangeName.Analy
{
	public class TypeDefAnalyzer : iAnalyze
	{
        public override bool Execute(object context)
        {
            var type = context as dnlib.DotNet.TypeDef;
            if (type == null) return false;

            bool isTypeEligibleForProcessing = true;

            if (type.IsRuntimeSpecialName || type.IsGlobalModuleType)
            {
                isTypeEligibleForProcessing = false; 
            }

            return isTypeEligibleForProcessing;
        }

    }
}
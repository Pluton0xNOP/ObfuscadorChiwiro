namespace Chiwiro.Protecciones.ChangeName.Analy
{
	public class MethodDefAnalyzer : iAnalyze
	{
		public override bool Execute(object context)
		{
            var method = context as dnlib.DotNet.MethodDef;
            if (method == null) return false;

            bool isMethodEligible = true; 

            if (method.IsRuntimeSpecialName || method.DeclaringType.IsForwarder)
            {
                isMethodEligible = false; 
            }

            return isMethodEligible;
        }
	}
}
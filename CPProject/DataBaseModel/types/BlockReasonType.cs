using System.ComponentModel;

namespace CPProject.DataBaseModel.types
{
    public enum BlockReasonType
    {
        [Description("None")]
        None,
        [Description("Violation of terms of service")]
        ViolationOfTermsOfService,
        [Description("Spamming")]
        Spamming,
        [Description("Suspected fraudulent activity")]
        SuspectedFraudulentActivity
    }
}

namespace Stateless
{
    internal static class Constants
    {
        internal static class ParameterConversionResources
        {
            internal const string ArgOfTypeRequiredInPosition = "An argument of type {0} is required in position {1}.";
            internal const string TooManyParameters = "Too many parameters have been supplied. Expecting {0} but got {1}.";
            internal const string WrongArgType = "The argument in position {0} is of type {1} but must be of type {2}.";
        }

        internal static class StateConfigurationResources
        {
            internal const string SelfTransitionsEitherIgnoredOrReentrant =
                "Permit() (and PermitIf()) require that the destination state is not equal to the source state. To accept a trigger without changing state, use either Ignore() or PermitReentry().";
        }

        internal static class StateMachineResources
        {
            internal const string CannotReconfigureParameters = "Parameters for the trigger '{0}' have already been configured.";
            internal const string NoTransitionsPermitted = "No valid leaving transitions are permitted from state '{1}' for trigger '{0}'. Consider ignoring the trigger.";
            internal const string NoTransitionsUnmetGuardConditions = "Trigger '{0}' is valid for transition from state '{1}' but a guard conditions are not met. Guard descriptions: '{2}'.";
        }

        internal static class StateRepresentationResources
        {
            internal const string MultipleTransitionsPermitted = "Multiple permitted exit transitions are configured from state '{1}' for trigger '{0}'. Guard clauses must be mutually exclusive.";
        }
    }
}
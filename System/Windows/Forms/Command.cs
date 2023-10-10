//----------------------
// <auto-generated>
//     Backwards compatibility with Menus.
// </auto-generated>
//----------------------
// System.Windows.Forms.Command
#if NETCOREAPP3_1_OR_GREATER
namespace System.Windows.Forms {
    internal class Command : IDisposable {
        private static readonly Type CommandType = typeof(Control).Assembly.GetType(typeof(Command).FullName);
        private static readonly Reflection.PropertyInfo CommandIDProperty = CommandType.GetProperty(nameof(ID), typeof(Int32));
        private static readonly Reflection.MethodInfo CommandDisposeMethod = CommandType.GetMethod(nameof(Dispose), Type.EmptyTypes);

        private readonly Object cmd;

        public Command(ICommandExecutor target) => this.cmd = Activator.CreateInstance(CommandType, target);

        public Int32 ID => (Int32)CommandIDProperty.GetValue(this.cmd);

        public void Dispose() => CommandDisposeMethod.Invoke(this.cmd, null);
    }
}
#endif
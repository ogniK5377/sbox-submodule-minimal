using Sandbox;

namespace MinimalExample
{
    public partial class MinimalGame
    {
        [ClientCmd( "cl_submodule_test" )]
		public static void ClTest() => DoSubmoduleTest();

		[ServerCmd( "sv_submodule_test" )]
		public static void SvTest() => DoSubmoduleTest();

		public static void DoSubmoduleTest()
		{
			Log.Info( $"Hello from submodule! Client: {Host.IsClient}, Server: {Host.IsServer}" );
		}
    }
}
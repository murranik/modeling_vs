#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"YaHZ")]
[assembly: AssemblyProduct(@"modeling_test")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"YaHZ.modeling_test.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010045FED1FAE869F6EEB25CAB8DE0AA768CBA911FBC66AC90700C37B8432D5CB1533073DA5D585AEE6035C76412DD86F3F9B7A7D1EFD4F00720DF6E47B8207F47E3248C0417E2674B3491410A5CAC6C9F04097425252FD469A72BD7B5D236F52943804E659072F27D5DD1DB2B907A3BD4967B9F314FFBF0A1E4F631E5F3281CE8A2")]
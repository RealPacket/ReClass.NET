using ReClassNET.Logger;
using ReClassNET.Nodes;
using ReClassNET.Project;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;

namespace ReClassNET.CodeGenerator;
public class RustCodeGenerator : ICodeGenerator
{
	public Language Language => Language.Rust;
	public string GenerateCode(
		IReadOnlyList<ClassNode> classes,
		IReadOnlyList<EnumDescription> enums,
		ILogger logger
	)
	{
		Contract.Requires(classes != null);
		Contract.Requires(Contract.ForAll(classes, c => c != null));
		Contract.Requires(logger != null);

		Contract.Ensures(Contract.Result<string>() != null);
		var sw = new StringWriter();
		sw.WriteLine($"// Generated by {Constants.AppDisplayName} {Constants.AppVersion} by {Constants.Author}");
		sw.WriteLine();
		sw.WriteLine("// WARNING: The Rust codegen module is new. ");
		sw.Write("This means that it might not be stable");
		return sw.ToString();
	}
}
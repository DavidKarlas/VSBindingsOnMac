using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"VSBindingsOnMac", 
	Namespace = "VSBindingsOnMac",
	Version = "1.0"
)]

[assembly:AddinName ("VSBindingsOnMac")]
[assembly:AddinCategory ("VSBindingsOnMac")]
[assembly:AddinDescription ("VSBindingsOnMac")]
[assembly:AddinAuthor ("David Karlaš")]

[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]

using System.Reflection;
using System.Runtime.CompilerServices;

//
// Les informations générales relatives à un assemblage dépendent de l'ensemble
// d'attributs suivant. Modifiez la valeur des attributs pour changer les
// informations associées à un assemblage.
//
[assembly: AssemblyTitle("DiagMagic")]
[assembly: AssemblyDescription("Générateur de grille de point de croix")]
[assembly: AssemblyConfiguration("DotNET Redistribuable Runtime 1.1 nécessaire")]
[assembly: AssemblyCompany("GLYS Informatique")]
[assembly: AssemblyProduct("DiagMagic")]
[assembly: AssemblyCopyright("Copyright © GLYS Informatique \n 2003/2004 \n Mathieu Lemoine")]
[assembly: AssemblyTrademark("GLYS Informatique\nDiagMagic")]
[assembly: AssemblyCulture("")]

//
// Les informations de version d'un assemblage se composent des quatre valeurs suivantes :
//
//      Version principale
//      Version secondaire
//      Numéro de build
//      Révision
//
// Vous pouvez spécifier toutes les valeurs ou indiquer des numéros de révision et de
// build par défaut en utilisant '*', comme ci-dessous :

[assembly: AssemblyVersion("4.0.*")]

//
// Pour signer l'assemblage, vous devez spécifier la clé à utiliser. Consultez la
// documentation Microsoft .NET Framework pour plus d'informations sur la signature des assemblages.
//
// Utilisez les attributs ci-dessous pour contrôler la clé utilisée lors de la signature.
//
// Remarques :
//   (*) Si aucune clé n'est spécifiée, l'assemblage n'est pas signé.
//   (*) KeyName fait référence à une clé installée dans le fournisseur de service
//       cryptographique (CSP) de votre ordinateur. KeyFile fait référence à un
//       fichier qui contient une clé.
//   (*) Si les valeurs de KeyFile et de KeyName sont spécifiées, le
//       traitement suivant se produit :
//       (1) Si KeyName se trouve dans le CSP, la clé est utilisée.
//       (2) Si KeyName n'existe pas mais que KeyFile existe, la clé
//           de KeyFile est installée dans le CSP et est utilisée.
//   (*) Pour créer KeyFile, vous pouvez utiliser l'utilitaire sn.exe (Strong Name).
//       Lors de la spécification de KeyFile, son emplacement doit être
//       relatif au répertoire de sortie du projet qui est
//       %Project Directory%\bin\<configuration>. Ainsi, si le KeyFile est situé
//       dans le répertoire du projet, vous devez spécifier l'attribut AssemblyKeyFile
//       sous la forme [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//   (*) La signature différée est une option avancée. Pour plus d'informations,
//       consultez la documentation Microsoft .NET Framework.
//
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("")]
[assembly: AssemblyKeyName("")]

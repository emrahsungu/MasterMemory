﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MasterMemory.CodeGenerator.Generator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CodeTemplate : CodeTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("#pragma warning disable 618\r\n#pragma warning disable 612\r\n#pragma warning disable" +
                    " 414\r\n#pragma warning disable 168\r\n\r\nnamespace ");
            
            #line 11 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using global::System;\r\n    using global::System.Collections.Generic;\r\n  " +
                    "  using global::System.Linq;\r\n    using global::ZeroFormatter.Formatters;\r\n\r\n   " +
                    " public static partial class MasterMemoryInitializer\r\n    {\r\n");
            
            #line 20 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 if( !UnuseUnityAttribute) { 
            
            #line default
            #line hidden
            this.Write("        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeL" +
                    "oadType.BeforeSceneLoad)]\r\n");
            
            #line 22 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        public static void Register()\r\n        {\r\n");
            
            #line 25 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 foreach(var def in enumDefinitions) { 
            
            #line default
            #line hidden
            this.Write("            MasterMemory.MasterMemoryComparer<");
            
            #line 26 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(def.FullName));
            
            #line default
            #line hidden
            this.Write(">.Default = new ");
            
            #line 26 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace + ".Comparers." + def.FullName.Replace(".", "_") + "_Comparer"));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 27 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 28 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 foreach(var def in elementDefinitions) {  
            
            #line default
            #line hidden
            this.Write("            ZeroFormatter.Formatters.Formatter.RegisterList<DefaultResolver, ");
            
            #line 29 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(def.FullName));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 30 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 31 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 foreach(var def in keyTupleDefinitions) { var t = string.Join(", ", def.FullNames);  
            
            #line default
            #line hidden
            this.Write("            MasterMemory.KeyTupleComparer.Register<");
            
            #line 32 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 33 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n    }\r\n}\r\n\r\nnamespace ");
            
            #line 38 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".Comparers\r\n{\r\n    using global::System;\r\n    using global::System.Collections.Ge" +
                    "neric;\r\n    using global::System.Linq;\r\n    using global::ZeroFormatter.Formatte" +
                    "rs;\r\n\r\n");
            
            #line 45 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
 foreach(var item in enumDefinitions) { 
            
            #line default
            #line hidden
            this.Write("\r\n    public class ");
            
            #line 47 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.FullName.Replace(".", "_") + "_Comparer"));
            
            #line default
            #line hidden
            this.Write(" : IComparer<");
            
            #line 47 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.FullName));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public int Compare(");
            
            #line 49 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.FullName));
            
            #line default
            #line hidden
            this.Write(" x, ");
            
            #line 49 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.FullName));
            
            #line default
            #line hidden
            this.Write(" y)\r\n        {\r\n            return ((");
            
            #line 51 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.UnderlyingType));
            
            #line default
            #line hidden
            this.Write(")x).CompareTo((");
            
            #line 51 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.UnderlyingType));
            
            #line default
            #line hidden
            this.Write(")y);\r\n        }\r\n    }\r\n\r\n");
            
            #line 55 "C:\Users\y.kawai\neuecc\MasterMemory\src\MasterMemory.CodeGenerator\Generator\CodeTemplate.tt"
} 
            
            #line default
            #line hidden
            this.Write("}\r\n\r\n#pragma warning restore 618\r\n#pragma warning restore 612\r\n#pragma warning re" +
                    "store 414\r\n#pragma warning restore 168");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class CodeTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
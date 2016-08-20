using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tril.Attributes;

namespace System
{
    [Annotation("java.lang", "android", "java")]
    [TypeName("string", "java")]
    public class String
    {
        [Annotation("hahaha", "android", "java")]
        [Comment("native", "android", "java")]
        [AccessModifier( AccessModifiers.Internal)]
        public string Normalize() { return null; }
        public System.Boolean IsNormalized([ParamType("sys.txt::NormalizationForm")]System.Text.NormalizationForm normalizationForm) 
        {
            return false; 
        }
    }
}

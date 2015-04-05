#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DelegateUtilityTests.cs" company="MorseCode Software">
// Copyright (c) 2015 MorseCode Software
// </copyright>
// <summary>
// The MIT License (MIT)
// 
// Copyright (c) 2015 MorseCode Software
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace MorseCode.FrameworkExtensions.Tests
{
    using System;
    using System.Reflection;

    using NUnit.Framework;

    [TestFixture]
    public class DelegateUtilityTests
    {
        #region Static Fields

        private static readonly MethodInfo ParseMethodInfo;

        private static readonly MethodInfo ParseStaticMethodInfo;

        #endregion

        #region Constructors and Destructors

        static DelegateUtilityTests()
        {
            ParseStaticMethodInfo = typeof(DelegateUtilityTests).GetMethod("ParseStatic", BindingFlags.Static | BindingFlags.NonPublic);
            ParseMethodInfo = typeof(DelegateUtilityTests).GetMethod("Parse", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        #endregion

        #region Public Methods and Operators

        [Test]
        public void CreateDelegate1()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(ParseStaticMethodInfo);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate1WithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(ParseStaticMethodInfo);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate2()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(ParseStaticMethodInfo, false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate2ThrowOnBindFailure()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(ParseStaticMethodInfo, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate2ThrowOnBindFailureWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(ParseStaticMethodInfo, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate2WithBindFailure()
        {
            Func<string, string> parseDelegate = DelegateUtility.CreateDelegate<Func<string, string>>(ParseStaticMethodInfo, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate3()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, ParseMethodInfo);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate3WithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(this, ParseMethodInfo);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate3Static()
        {
            Func<int> parseDelegate = DelegateUtility.CreateDelegate<Func<int>>("5", ParseStaticMethodInfo);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate());
        }

        [Test]
        public void CreateDelegate3StaticWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string>>("5", ParseStaticMethodInfo);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate4()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "Parse");

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(this.Parse("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate4WithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(this, "Parse");
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate5()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "ParseStatic");

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate5WithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(typeof(DelegateUtilityTests), "ParseStatic");
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate6()
        {
            Func<int> parseDelegate = DelegateUtility.CreateDelegate<Func<int>>("5", ParseStaticMethodInfo, false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate());
        }

        [Test]
        public void CreateDelegate6ThrowOnBindFailure()
        {
            Func<int> parseDelegate = DelegateUtility.CreateDelegate<Func<int>>("5", ParseStaticMethodInfo, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate());
        }

        [Test]
        public void CreateDelegate6ThrowOnBindFailureWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string>>("5", ParseStaticMethodInfo, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate6WithBindFailure()
        {
            Func<string> parseDelegate = DelegateUtility.CreateDelegate<Func<string>>("5", ParseStaticMethodInfo, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate7()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "Parse", false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate7WithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(this, "Parse", false);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate7WithWrongCase()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, int>>(this, "parse", false);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate7IgnoreCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "Parse", true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate7IgnoreCaseWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(this, "Parse", true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate7IgnoreCaseWithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "parse", true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate8()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "ParseStatic", false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate8WithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(typeof(DelegateUtilityTests), "ParseStatic", false);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate8WithWrongCase()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "parsestatic", false);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate8IgnoreCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "ParseStatic", true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate8IgnoreCaseWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(typeof(DelegateUtilityTests), "ParseStatic", true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate8IgnoreCaseWithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "parsestatic", true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate9()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "Parse", false, false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate9WithBindFailure()
        {
            Func<string, string> parseDelegate = DelegateUtility.CreateDelegate<Func<string, string>>(this, "Parse", false, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate9WithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "parse", false, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate9IgnoreCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "Parse", true, false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate9IgnoreCaseWithBindFailure()
        {
            Func<string, string> parseDelegate = DelegateUtility.CreateDelegate<Func<string, string>>(this, "Parse", true, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate9IgnoreCaseWithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "parse", true, false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate9ThrowOnBindFailure()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "Parse", false, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate9ThrowOnBindFailureWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(this, "Parse", false, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate9ThrowOnBindFailureWithWrongCase()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, int>>(this, "parse", false, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate9IgnoreCaseThrowOnBindFailure()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "Parse", true, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate9IgnoreCaseThrowOnBindFailureWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(this, "Parse", true, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate9IgnoreCaseThrowOnBindFailureWithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(this, "parse", true, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate10()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "ParseStatic", false,false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate10WithBindFailure()
        {
            Func<string, string> parseDelegate = DelegateUtility.CreateDelegate<Func<string, string>>(typeof(DelegateUtilityTests), "ParseStatic", false, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate10WithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "parsestatic", false, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate10IgnoreCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "ParseStatic", true, false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate10IgnoreCaseWithBindFailure()
        {
            Func<string, string> parseDelegate = DelegateUtility.CreateDelegate<Func<string, string>>(typeof(DelegateUtilityTests), "parsestatic", true, false);

            Assert.IsNull(parseDelegate);
        }

        [Test]
        public void CreateDelegate10IgnoreCaseWithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "parsestatic", true, false);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate10ThrowOnBindFailure()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "ParseStatic", false, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate10ThrowOnBindFailureWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(typeof(DelegateUtilityTests), "ParseStatic", false, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate10ThrowOnBindFailureWithWrongCase()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "parsestatic", false, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate10IgnoreCaseThrowOnBindFailure()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "ParseStatic", true, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        [Test]
        public void CreateDelegate10IgnoreCaseThrowOnBindFailureWithBindFailure()
        {
            ArgumentException actualException = null;
            try
            {
                DelegateUtility.CreateDelegate<Func<string, string>>(typeof(DelegateUtilityTests), "ParseStatic", true, true);
            }
            catch (ArgumentException e)
            {
                actualException = e;
            }

            Assert.IsNotNull(actualException);
            Assert.AreEqual("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.", actualException.Message);
        }

        [Test]
        public void CreateDelegate10IgnoreCaseThrowOnBindFailureWithWrongCase()
        {
            Func<string, int> parseDelegate = DelegateUtility.CreateDelegate<Func<string, int>>(typeof(DelegateUtilityTests), "parsestatic", true, true);

            Assert.IsNotNull(parseDelegate);
            Assert.AreEqual(ParseStatic("5"), parseDelegate("5"));
        }

        #endregion

        #region Methods

        private static int ParseStatic(string s)
        {
            return int.Parse(s);
        }

        private int Parse(string s)
        {
            return int.Parse(s);
        }

        #endregion
    }
}
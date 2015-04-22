#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExplicitExpressionTests.cs" company="MorseCode Software">
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
    using System.Linq.Expressions;
    using System.Reflection;

    using NUnit.Framework;

    [TestFixture]
    public class ExplicitExpressionTests
    {
        #region Public Methods and Operators

        [Test]
        public void Create()
        {
            ExplicitExpression<Test, int> explicitExpression = ExplicitExpression<Test>.Create(o => o.Property);

            Assert.IsNotNull(explicitExpression);
            Assert.IsNotNull(explicitExpression.Expression);
            Assert.IsInstanceOf<Expression<Func<Test, int?>>>(explicitExpression.Expression);
            Assert.IsNotNull(explicitExpression.Expression.Body);
            Assert.IsInstanceOf<MemberExpression>(explicitExpression.Expression.Body);
            MemberExpression memberExpression = (MemberExpression)explicitExpression.Expression.Body;
            Assert.IsNotNull(memberExpression.Member);
            Assert.IsInstanceOf<PropertyInfo>(memberExpression.Member);
            PropertyInfo property = (PropertyInfo)memberExpression.Member;
            Assert.AreEqual("Property", property.Name);
            Assert.AreEqual(typeof(int), property.PropertyType);
        }

        [Test]
        public void TypeInference()
        {
            this.Method(o => o.Property);
            this.MethodWithWrongType(o => o.Property);

            this.Method(ExplicitExpression<Test>.Create(o => o.Property).Expression);
            // NOTE: should not compile
            //MethodWithWrongType(ExplicitExpression<Test>.Create(o => o.Property).Expression);
        }

        #endregion

        // ReSharper disable UnusedParameter.Local
        #region Methods

        private void Method(Expression<Func<Test, int>> propertyExpression)
            // ReSharper restore UnusedParameter.Local
        {
        }

        // ReSharper disable UnusedParameter.Local
        private void MethodWithWrongType(Expression<Func<Test, int?>> propertyExpression)
            // ReSharper restore UnusedParameter.Local
        {
        }

        #endregion

        // ReSharper disable ClassNeverInstantiated.Local
        private class Test
            // ReSharper restore ClassNeverInstantiated.Local
        {
            // ReSharper disable UnusedAutoPropertyAccessor.Local
            #region Public Properties

            public int Property { get; set; }

            #endregion

            // ReSharper restore UnusedAutoPropertyAccessor.Local
        }
    }
}
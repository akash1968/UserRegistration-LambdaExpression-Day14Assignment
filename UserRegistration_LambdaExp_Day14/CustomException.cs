// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomException.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.ExceptionServices;

namespace UserRegistration_LambdaExp_Day14
{
   public class CustomException : ApplicationException
    {
        public enum ExceptionType
        {
            INVALID_DETAILS
        }
        public readonly ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

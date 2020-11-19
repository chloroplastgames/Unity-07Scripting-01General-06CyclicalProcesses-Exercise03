/// INFORMATION
///
/// Project:
/// Game:
/// Data:
/// Author:
/// Programmers:
/// Description:
///

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class NegativeValueException : UnityException
{
    public NegativeValueException()
    {
    }

    public NegativeValueException(string message) : base(message)
    {
    }

    public NegativeValueException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected NegativeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

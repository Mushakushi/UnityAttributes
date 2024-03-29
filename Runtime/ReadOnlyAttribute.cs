﻿// modified from https://answers.unity.com/questions/489942/how-to-make-a-readonly-property-in-inspector.html
using UnityEngine;

/// <summary>
/// Makes a property read only.  
/// </summary>
public sealed class ReadOnlyAttribute : PropertyAttribute { }

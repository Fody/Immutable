﻿namespace YourCode
{
    [Immutable]
    public class Sample
    {
        public string MyField = "Foo";
    }
}
namespace WhatGetsCompile
{
    public class Sample
    {
        public readonly string MyField = "Foo";
    }
}

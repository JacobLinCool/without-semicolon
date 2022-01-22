# Write Code Without Semicolon in C#

You can use `if` or `while` statement in C# to write code without semicolons.
If the method has return value, use `&&` operator to call multiple method.

```csharp
if (Method() == someVal && expression && expression) {}
```

If the method has no return value, use `is` operator to check type. By that you will get an valid expression.

```csharp
if (VoidMethod() is object) {}
```

*You will get CS0184 warning, which can hide by adding preprocessor `#pragma warning disable CS0184`.

# C# Strings
A *string* is a sequence of characters. In C#, `string` is the language keyword for the `System.String` type. Every string literal you write produces a `System.String` instance.

## String literals
C# offers four literal forms. Each form suits different content. As a quick guide:
- Use **regular literals** for short, simple text with at most a few escape sequences.
- Use **verbatim literals** when backslashes dominate the content, such as Windows paths or regex patterns, but prefer **raw string literals** for new code for the same functionality.
- Use **raw string literals** for multiline or structurally formatted text, such as inline JSON, SQL, XML, or formatted message blocks.
- Add a `$` prefix to any of the aforementioned literals to get an **interpolated string** when you need to embed values.
- Add a `u8` suffix to a literal to produce a UTF-8 byte sequence (a `ReadOnlySpan<T>` of `byte`) for byte-oriented APIs. See UTF-8 string literals in the language reference for details.

﻿using System;
using Xunit;
// Autogenerated
// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable InconsistentNaming
namespace SpanJson.Tests
{
    public class EnumFlagsTests
    {
		
		[Flags]
		public enum SByteEnum : SByte
		{
			MinValue = SByte.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = SByte.MaxValue
		}


        [Theory]
        [InlineData(SByteEnum.MinValue)]
        [InlineData(SByteEnum.MaxValue)]
        [InlineData(SByteEnum.MinValue | SByteEnum.MaxValue)]
		[InlineData(SByteEnum.Two)]
		[InlineData(SByteEnum.Two | SByteEnum.Four)]
		[InlineData(SByteEnum.Two | SByteEnum.Four | SByteEnum.Eight)]
        public void SerializeDeserializeSByteEnumUtf8(SByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<SByteEnum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(SByteEnum.MinValue)]
        [InlineData(SByteEnum.MaxValue)]
        [InlineData(SByteEnum.MinValue | SByteEnum.MaxValue)]
		[InlineData(SByteEnum.Two)]
		[InlineData(SByteEnum.Two | SByteEnum.Four)]
		[InlineData(SByteEnum.Two | SByteEnum.Four | SByteEnum.Eight)]
        public void SerializeDeserializeSByteEnumUtf16(SByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<SByteEnum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(SByteEnum.MinValue)]
        [InlineData(SByteEnum.MaxValue)]
        [InlineData(SByteEnum.MinValue | SByteEnum.MaxValue)]
		[InlineData(SByteEnum.Two)]
		[InlineData(SByteEnum.Two | SByteEnum.Four)]
		[InlineData(SByteEnum.Two | SByteEnum.Four | SByteEnum.Eight)]
        public void SerializeDeserializeIntegerSByteEnumUtf8(SByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<SByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<SByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(SByteEnum.MinValue)]
        [InlineData(SByteEnum.MaxValue)]
        [InlineData(SByteEnum.MinValue | SByteEnum.MaxValue)]
		[InlineData(SByteEnum.Two)]
		[InlineData(SByteEnum.Two | SByteEnum.Four)]
		[InlineData(SByteEnum.Two | SByteEnum.Four | SByteEnum.Eight)]
        public void SerializeDeserializeIntegerSByteEnumUtf16(SByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<SByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<SByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
		
		[Flags]
		public enum Int16Enum : Int16
		{
			MinValue = Int16.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = Int16.MaxValue
		}


        [Theory]
        [InlineData(Int16Enum.MinValue)]
        [InlineData(Int16Enum.MaxValue)]
        [InlineData(Int16Enum.MinValue | Int16Enum.MaxValue)]
		[InlineData(Int16Enum.Two)]
		[InlineData(Int16Enum.Two | Int16Enum.Four)]
		[InlineData(Int16Enum.Two | Int16Enum.Four | Int16Enum.Eight)]
        public void SerializeDeserializeInt16EnumUtf8(Int16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int16Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int16Enum.MinValue)]
        [InlineData(Int16Enum.MaxValue)]
        [InlineData(Int16Enum.MinValue | Int16Enum.MaxValue)]
		[InlineData(Int16Enum.Two)]
		[InlineData(Int16Enum.Two | Int16Enum.Four)]
		[InlineData(Int16Enum.Two | Int16Enum.Four | Int16Enum.Eight)]
        public void SerializeDeserializeInt16EnumUtf16(Int16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int16Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int16Enum.MinValue)]
        [InlineData(Int16Enum.MaxValue)]
        [InlineData(Int16Enum.MinValue | Int16Enum.MaxValue)]
		[InlineData(Int16Enum.Two)]
		[InlineData(Int16Enum.Two | Int16Enum.Four)]
		[InlineData(Int16Enum.Two | Int16Enum.Four | Int16Enum.Eight)]
        public void SerializeDeserializeIntegerInt16EnumUtf8(Int16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<Int16Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int16Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int16Enum.MinValue)]
        [InlineData(Int16Enum.MaxValue)]
        [InlineData(Int16Enum.MinValue | Int16Enum.MaxValue)]
		[InlineData(Int16Enum.Two)]
		[InlineData(Int16Enum.Two | Int16Enum.Four)]
		[InlineData(Int16Enum.Two | Int16Enum.Four | Int16Enum.Eight)]
        public void SerializeDeserializeIntegerInt16EnumUtf16(Int16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<Int16Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int16Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
		
		[Flags]
		public enum Int32Enum : Int32
		{
			MinValue = Int32.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = Int32.MaxValue
		}


        [Theory]
        [InlineData(Int32Enum.MinValue)]
        [InlineData(Int32Enum.MaxValue)]
        [InlineData(Int32Enum.MinValue | Int32Enum.MaxValue)]
		[InlineData(Int32Enum.Two)]
		[InlineData(Int32Enum.Two | Int32Enum.Four)]
		[InlineData(Int32Enum.Two | Int32Enum.Four | Int32Enum.Eight)]
        public void SerializeDeserializeInt32EnumUtf8(Int32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int32Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int32Enum.MinValue)]
        [InlineData(Int32Enum.MaxValue)]
        [InlineData(Int32Enum.MinValue | Int32Enum.MaxValue)]
		[InlineData(Int32Enum.Two)]
		[InlineData(Int32Enum.Two | Int32Enum.Four)]
		[InlineData(Int32Enum.Two | Int32Enum.Four | Int32Enum.Eight)]
        public void SerializeDeserializeInt32EnumUtf16(Int32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int32Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int32Enum.MinValue)]
        [InlineData(Int32Enum.MaxValue)]
        [InlineData(Int32Enum.MinValue | Int32Enum.MaxValue)]
		[InlineData(Int32Enum.Two)]
		[InlineData(Int32Enum.Two | Int32Enum.Four)]
		[InlineData(Int32Enum.Two | Int32Enum.Four | Int32Enum.Eight)]
        public void SerializeDeserializeIntegerInt32EnumUtf8(Int32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<Int32Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int32Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int32Enum.MinValue)]
        [InlineData(Int32Enum.MaxValue)]
        [InlineData(Int32Enum.MinValue | Int32Enum.MaxValue)]
		[InlineData(Int32Enum.Two)]
		[InlineData(Int32Enum.Two | Int32Enum.Four)]
		[InlineData(Int32Enum.Two | Int32Enum.Four | Int32Enum.Eight)]
        public void SerializeDeserializeIntegerInt32EnumUtf16(Int32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<Int32Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int32Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
		
		[Flags]
		public enum Int64Enum : Int64
		{
			MinValue = Int64.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = Int64.MaxValue
		}


        [Theory]
        [InlineData(Int64Enum.MinValue)]
        [InlineData(Int64Enum.MaxValue)]
        [InlineData(Int64Enum.MinValue | Int64Enum.MaxValue)]
		[InlineData(Int64Enum.Two)]
		[InlineData(Int64Enum.Two | Int64Enum.Four)]
		[InlineData(Int64Enum.Two | Int64Enum.Four | Int64Enum.Eight)]
        public void SerializeDeserializeInt64EnumUtf8(Int64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int64Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int64Enum.MinValue)]
        [InlineData(Int64Enum.MaxValue)]
        [InlineData(Int64Enum.MinValue | Int64Enum.MaxValue)]
		[InlineData(Int64Enum.Two)]
		[InlineData(Int64Enum.Two | Int64Enum.Four)]
		[InlineData(Int64Enum.Two | Int64Enum.Four | Int64Enum.Eight)]
        public void SerializeDeserializeInt64EnumUtf16(Int64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int64Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int64Enum.MinValue)]
        [InlineData(Int64Enum.MaxValue)]
        [InlineData(Int64Enum.MinValue | Int64Enum.MaxValue)]
		[InlineData(Int64Enum.Two)]
		[InlineData(Int64Enum.Two | Int64Enum.Four)]
		[InlineData(Int64Enum.Two | Int64Enum.Four | Int64Enum.Eight)]
        public void SerializeDeserializeIntegerInt64EnumUtf8(Int64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<Int64Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int64Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(Int64Enum.MinValue)]
        [InlineData(Int64Enum.MaxValue)]
        [InlineData(Int64Enum.MinValue | Int64Enum.MaxValue)]
		[InlineData(Int64Enum.Two)]
		[InlineData(Int64Enum.Two | Int64Enum.Four)]
		[InlineData(Int64Enum.Two | Int64Enum.Four | Int64Enum.Eight)]
        public void SerializeDeserializeIntegerInt64EnumUtf16(Int64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<Int64Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int64Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
		
		[Flags]
		public enum ByteEnum : Byte
		{
			MinValue = Byte.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = Byte.MaxValue
		}


        [Theory]
        [InlineData(ByteEnum.MinValue)]
        [InlineData(ByteEnum.MaxValue)]
		[InlineData(ByteEnum.Two)]
		[InlineData(ByteEnum.Two | ByteEnum.Four)]
		[InlineData(ByteEnum.Two | ByteEnum.Four | ByteEnum.Eight)]
        public void SerializeDeserializeByteEnumUtf8(ByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<ByteEnum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(ByteEnum.MinValue)]
        [InlineData(ByteEnum.MaxValue)]
		[InlineData(ByteEnum.Two)]
		[InlineData(ByteEnum.Two | ByteEnum.Four)]
		[InlineData(ByteEnum.Two | ByteEnum.Four | ByteEnum.Eight)]
        public void SerializeDeserializeByteEnumUtf16(ByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<ByteEnum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(ByteEnum.MinValue)]
        [InlineData(ByteEnum.MaxValue)]
		[InlineData(ByteEnum.Two)]
		[InlineData(ByteEnum.Two | ByteEnum.Four)]
		[InlineData(ByteEnum.Two | ByteEnum.Four | ByteEnum.Eight)]
        public void SerializeDeserializeIntegerByteEnumUtf8(ByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<ByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<ByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(ByteEnum.MinValue)]
        [InlineData(ByteEnum.MaxValue)]
		[InlineData(ByteEnum.Two)]
		[InlineData(ByteEnum.Two | ByteEnum.Four)]
		[InlineData(ByteEnum.Two | ByteEnum.Four | ByteEnum.Eight)]
        public void SerializeDeserializeIntegerByteEnumUtf16(ByteEnum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<ByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<ByteEnum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
		
		[Flags]
		public enum UInt16Enum : UInt16
		{
			MinValue = UInt16.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = UInt16.MaxValue
		}


        [Theory]
        [InlineData(UInt16Enum.MinValue)]
        [InlineData(UInt16Enum.MaxValue)]
		[InlineData(UInt16Enum.Two)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four | UInt16Enum.Eight)]
        public void SerializeDeserializeUInt16EnumUtf8(UInt16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt16Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt16Enum.MinValue)]
        [InlineData(UInt16Enum.MaxValue)]
		[InlineData(UInt16Enum.Two)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four | UInt16Enum.Eight)]
        public void SerializeDeserializeUInt16EnumUtf16(UInt16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt16Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt16Enum.MinValue)]
        [InlineData(UInt16Enum.MaxValue)]
		[InlineData(UInt16Enum.Two)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four | UInt16Enum.Eight)]
        public void SerializeDeserializeIntegerUInt16EnumUtf8(UInt16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<UInt16Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt16Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt16Enum.MinValue)]
        [InlineData(UInt16Enum.MaxValue)]
		[InlineData(UInt16Enum.Two)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four)]
		[InlineData(UInt16Enum.Two | UInt16Enum.Four | UInt16Enum.Eight)]
        public void SerializeDeserializeIntegerUInt16EnumUtf16(UInt16Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<UInt16Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt16Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
		
		[Flags]
		public enum UInt32Enum : UInt32
		{
			MinValue = UInt32.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = UInt32.MaxValue
		}


        [Theory]
        [InlineData(UInt32Enum.MinValue)]
        [InlineData(UInt32Enum.MaxValue)]
		[InlineData(UInt32Enum.Two)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four | UInt32Enum.Eight)]
        public void SerializeDeserializeUInt32EnumUtf8(UInt32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt32Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt32Enum.MinValue)]
        [InlineData(UInt32Enum.MaxValue)]
		[InlineData(UInt32Enum.Two)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four | UInt32Enum.Eight)]
        public void SerializeDeserializeUInt32EnumUtf16(UInt32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt32Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt32Enum.MinValue)]
        [InlineData(UInt32Enum.MaxValue)]
		[InlineData(UInt32Enum.Two)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four | UInt32Enum.Eight)]
        public void SerializeDeserializeIntegerUInt32EnumUtf8(UInt32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<UInt32Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt32Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt32Enum.MinValue)]
        [InlineData(UInt32Enum.MaxValue)]
		[InlineData(UInt32Enum.Two)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four)]
		[InlineData(UInt32Enum.Two | UInt32Enum.Four | UInt32Enum.Eight)]
        public void SerializeDeserializeIntegerUInt32EnumUtf16(UInt32Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<UInt32Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt32Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
		
		[Flags]
		public enum UInt64Enum : UInt64
		{
			MinValue = UInt64.MinValue,
			Two = 2,
			Four = 4,
			Eight = 8,
			MaxValue = UInt64.MaxValue
		}


        [Theory]
        [InlineData(UInt64Enum.MinValue)]
        [InlineData(UInt64Enum.MaxValue)]
		[InlineData(UInt64Enum.Two)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four | UInt64Enum.Eight)]
        public void SerializeDeserializeUInt64EnumUtf8(UInt64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt64Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt64Enum.MinValue)]
        [InlineData(UInt64Enum.MaxValue)]
		[InlineData(UInt64Enum.Two)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four | UInt64Enum.Eight)]
        public void SerializeDeserializeUInt64EnumUtf16(UInt64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt64Enum>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt64Enum.MinValue)]
        [InlineData(UInt64Enum.MaxValue)]
		[InlineData(UInt64Enum.Two)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four | UInt64Enum.Eight)]
        public void SerializeDeserializeIntegerUInt64EnumUtf8(UInt64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize<UInt64Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt64Enum, ExcludeNullCamelCaseIntegerEnumResolver<byte>>(serialized);
            Assert.Equal(input, deserialized);
        }

        [Theory]
        [InlineData(UInt64Enum.MinValue)]
        [InlineData(UInt64Enum.MaxValue)]
		[InlineData(UInt64Enum.Two)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four)]
		[InlineData(UInt64Enum.Two | UInt64Enum.Four | UInt64Enum.Eight)]
        public void SerializeDeserializeIntegerUInt64EnumUtf16(UInt64Enum input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize<UInt64Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt64Enum, ExcludeNullCamelCaseIntegerEnumResolver<char>>(serialized);
            Assert.Equal(input, deserialized);
        }
    }
}
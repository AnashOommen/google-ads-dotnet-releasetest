// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/feed_attribute_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/feed_attribute_type.proto</summary>
  public static partial class FeedAttributeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/feed_attribute_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedAttributeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvZmVlZF9hdHRyaWJ1",
            "dGVfdHlwZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLmVudW1z",
            "IoQCChVGZWVkQXR0cmlidXRlVHlwZUVudW0i6gEKEUZlZWRBdHRyaWJ1dGVU",
            "eXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgkKBUlOVDY0EAIS",
            "CgoGRE9VQkxFEAMSCgoGU1RSSU5HEAQSCwoHQk9PTEVBThAFEgcKA1VSTBAG",
            "Eg0KCURBVEVfVElNRRAHEg4KCklOVDY0X0xJU1QQCBIPCgtET1VCTEVfTElT",
            "VBAJEg8KC1NUUklOR19MSVNUEAoSEAoMQk9PTEVBTl9MSVNUEAsSDAoIVVJM",
            "X0xJU1QQDBISCg5EQVRFX1RJTUVfTElTVBANEgkKBVBSSUNFEA5C8AEKImNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZW51bXNCFkZlZWRBdHRyaWJ1",
            "dGVUeXBlUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMS9lbnVtcztlbnVtc6ICA0dBQaoC",
            "Hkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5FbnVtc8oCHkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxMVxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxMTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.FeedAttributeTypeEnum), global::Google.Ads.GoogleAds.V11.Enums.FeedAttributeTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.FeedAttributeTypeEnum.Types.FeedAttributeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible data types for a feed attribute.
  /// </summary>
  public sealed partial class FeedAttributeTypeEnum : pb::IMessage<FeedAttributeTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedAttributeTypeEnum> _parser = new pb::MessageParser<FeedAttributeTypeEnum>(() => new FeedAttributeTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedAttributeTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.FeedAttributeTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedAttributeTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedAttributeTypeEnum(FeedAttributeTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedAttributeTypeEnum Clone() {
      return new FeedAttributeTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedAttributeTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedAttributeTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeedAttributeTypeEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the FeedAttributeTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible data types for a feed attribute.
      /// </summary>
      public enum FeedAttributeType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Int64.
        /// </summary>
        [pbr::OriginalName("INT64")] Int64 = 2,
        /// <summary>
        /// Double.
        /// </summary>
        [pbr::OriginalName("DOUBLE")] Double = 3,
        /// <summary>
        /// String.
        /// </summary>
        [pbr::OriginalName("STRING")] String = 4,
        /// <summary>
        /// Boolean.
        /// </summary>
        [pbr::OriginalName("BOOLEAN")] Boolean = 5,
        /// <summary>
        /// Url.
        /// </summary>
        [pbr::OriginalName("URL")] Url = 6,
        /// <summary>
        /// Datetime.
        /// </summary>
        [pbr::OriginalName("DATE_TIME")] DateTime = 7,
        /// <summary>
        /// Int64 list.
        /// </summary>
        [pbr::OriginalName("INT64_LIST")] Int64List = 8,
        /// <summary>
        /// Double (8 bytes) list.
        /// </summary>
        [pbr::OriginalName("DOUBLE_LIST")] DoubleList = 9,
        /// <summary>
        /// String list.
        /// </summary>
        [pbr::OriginalName("STRING_LIST")] StringList = 10,
        /// <summary>
        /// Boolean list.
        /// </summary>
        [pbr::OriginalName("BOOLEAN_LIST")] BooleanList = 11,
        /// <summary>
        /// Url list.
        /// </summary>
        [pbr::OriginalName("URL_LIST")] UrlList = 12,
        /// <summary>
        /// Datetime list.
        /// </summary>
        [pbr::OriginalName("DATE_TIME_LIST")] DateTimeList = 13,
        /// <summary>
        /// Price.
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 14,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code

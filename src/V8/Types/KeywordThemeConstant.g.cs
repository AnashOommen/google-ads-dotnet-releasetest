// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/resources/keyword_theme_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/resources/keyword_theme_constant.proto</summary>
  public static partial class KeywordThemeConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/resources/keyword_theme_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordThemeConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXMva2V5d29yZF90",
            "aGVtZV9jb25zdGFudC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjgu",
            "cmVzb3VyY2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhln",
            "b29nbGUvYXBpL3Jlc291cmNlLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvIvQCChRLZXl3b3JkVGhlbWVDb25zdGFudBJMCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJQjXgQQP6QS8KLWdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9LZXl3b3JkVGhlbWVDb25zdGFudBIeCgxjb3VudHJ5X2NvZGUYAiABKAlC",
            "A+BBA0gAiAEBEh8KDWxhbmd1YWdlX2NvZGUYAyABKAlCA+BBA0gBiAEBEh4K",
            "DGRpc3BsYXlfbmFtZRgEIAEoCUID4EEDSAKIAQE6eepBdgotZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0tleXdvcmRUaGVtZUNvbnN0YW50EkVrZXl3b3Jk",
            "VGhlbWVDb25zdGFudHMve2V4cHJlc3NfY2F0ZWdvcnlfaWR9fntleHByZXNz",
            "X3N1Yl9jYXRlZ29yeV9pZH1CDwoNX2NvdW50cnlfY29kZUIQCg5fbGFuZ3Vh",
            "Z2VfY29kZUIPCg1fZGlzcGxheV9uYW1lQoYCCiVjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjgucmVzb3VyY2VzQhlLZXl3b3JkVGhlbWVDb25zdGFudFBy",
            "b3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIh",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjguUmVzb3VyY2VzygIhR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjhcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6Vjg6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Resources.KeywordThemeConstant), global::Google.Ads.GoogleAds.V8.Resources.KeywordThemeConstant.Parser, new[]{ "ResourceName", "CountryCode", "LanguageCode", "DisplayName" }, new[]{ "CountryCode", "LanguageCode", "DisplayName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Smart Campaign keyword theme constant.
  /// </summary>
  public sealed partial class KeywordThemeConstant : pb::IMessage<KeywordThemeConstant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordThemeConstant> _parser = new pb::MessageParser<KeywordThemeConstant>(() => new KeywordThemeConstant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordThemeConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Resources.KeywordThemeConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordThemeConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordThemeConstant(KeywordThemeConstant other) : this() {
      resourceName_ = other.resourceName_;
      countryCode_ = other.countryCode_;
      languageCode_ = other.languageCode_;
      displayName_ = other.displayName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordThemeConstant Clone() {
      return new KeywordThemeConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the keyword theme constant.
    /// Keyword theme constant resource names have the form:
    ///
    /// `keywordThemeConstants/{keyword_theme_id}~{sub_keyword_theme_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 2;
    private string countryCode_;
    /// <summary>
    /// Output only. The ISO-3166 Alpha-2 country code of the constant, eg. "US".
    /// To display and query matching purpose, the keyword theme needs to be
    /// localized.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CountryCode {
      get { return countryCode_ ?? ""; }
      set {
        countryCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "country_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCountryCode {
      get { return countryCode_ != null; }
    }
    /// <summary>Clears the value of the "country_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCountryCode() {
      countryCode_ = null;
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 3;
    private string languageCode_;
    /// <summary>
    /// Output only. The ISO-639-1 language code with 2 letters of the constant, eg. "en".
    /// To display and query matching purpose, the keyword theme needs to be
    /// localized.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LanguageCode {
      get { return languageCode_ ?? ""; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "language_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLanguageCode {
      get { return languageCode_ != null; }
    }
    /// <summary>Clears the value of the "language_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLanguageCode() {
      languageCode_ = null;
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 4;
    private string displayName_;
    /// <summary>
    /// Output only. The display name of the keyword theme or sub keyword theme.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_ ?? ""; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "display_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDisplayName {
      get { return displayName_ != null; }
    }
    /// <summary>Clears the value of the "display_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDisplayName() {
      displayName_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordThemeConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordThemeConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CountryCode != other.CountryCode) return false;
      if (LanguageCode != other.LanguageCode) return false;
      if (DisplayName != other.DisplayName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCountryCode) hash ^= CountryCode.GetHashCode();
      if (HasLanguageCode) hash ^= LanguageCode.GetHashCode();
      if (HasDisplayName) hash ^= DisplayName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasCountryCode) {
        output.WriteRawTag(18);
        output.WriteString(CountryCode);
      }
      if (HasLanguageCode) {
        output.WriteRawTag(26);
        output.WriteString(LanguageCode);
      }
      if (HasDisplayName) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasCountryCode) {
        output.WriteRawTag(18);
        output.WriteString(CountryCode);
      }
      if (HasLanguageCode) {
        output.WriteRawTag(26);
        output.WriteString(LanguageCode);
      }
      if (HasDisplayName) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasCountryCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CountryCode);
      }
      if (HasLanguageCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (HasDisplayName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KeywordThemeConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCountryCode) {
        CountryCode = other.CountryCode;
      }
      if (other.HasLanguageCode) {
        LanguageCode = other.LanguageCode;
      }
      if (other.HasDisplayName) {
        DisplayName = other.DisplayName;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            CountryCode = input.ReadString();
            break;
          }
          case 26: {
            LanguageCode = input.ReadString();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            CountryCode = input.ReadString();
            break;
          }
          case 26: {
            LanguageCode = input.ReadString();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
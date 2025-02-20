// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/customer_client.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/customer_client.proto</summary>
  public static partial class CustomerClientReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/customer_client.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerClientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "Y2xpZW50LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52OS5yZXNvdXJj",
            "ZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8itQUKDkN1c3RvbWVyQ2xpZW50EkYKDXJlc291",
            "cmNlX25hbWUYASABKAlCL+BBA/pBKQonZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0N1c3RvbWVyQ2xpZW50EkcKD2NsaWVudF9jdXN0b21lchgMIAEoCUIp",
            "4EED+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJIAIgB",
            "ARIYCgZoaWRkZW4YDSABKAhCA+BBA0gBiAEBEhcKBWxldmVsGA4gASgDQgPg",
            "QQNIAogBARIbCgl0aW1lX3pvbmUYDyABKAlCA+BBA0gDiAEBEh4KDHRlc3Rf",
            "YWNjb3VudBgQIAEoCEID4EEDSASIAQESGQoHbWFuYWdlchgRIAEoCEID4EED",
            "SAWIAQESIgoQZGVzY3JpcHRpdmVfbmFtZRgSIAEoCUID4EEDSAaIAQESHwoN",
            "Y3VycmVuY3lfY29kZRgTIAEoCUID4EEDSAeIAQESFAoCaWQYFCABKANCA+BB",
            "A0gIiAEBEj4KDmFwcGxpZWRfbGFiZWxzGBUgAygJQibgQQP6QSAKHmdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9MYWJlbDpq6kFnCidnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vQ3VzdG9tZXJDbGllbnQSPGN1c3RvbWVycy97Y3VzdG9t",
            "ZXJfaWR9L2N1c3RvbWVyQ2xpZW50cy97Y2xpZW50X2N1c3RvbWVyX2lkfUIS",
            "ChBfY2xpZW50X2N1c3RvbWVyQgkKB19oaWRkZW5CCAoGX2xldmVsQgwKCl90",
            "aW1lX3pvbmVCDwoNX3Rlc3RfYWNjb3VudEIKCghfbWFuYWdlckITChFfZGVz",
            "Y3JpcHRpdmVfbmFtZUIQCg5fY3VycmVuY3lfY29kZUIFCgNfaWRCgAIKJWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5yZXNvdXJjZXNCE0N1c3RvbWVy",
            "Q2xpZW50UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5L3Jlc291cmNlcztyZXNvdXJjZXOi",
            "AgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5SZXNvdXJjZXPKAiFH",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWOVxSZXNvdXJjZXPqAiVHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWOTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.CustomerClient), global::Google.Ads.GoogleAds.V9.Resources.CustomerClient.Parser, new[]{ "ResourceName", "ClientCustomer", "Hidden", "Level", "TimeZone", "TestAccount", "Manager", "DescriptiveName", "CurrencyCode", "Id", "AppliedLabels" }, new[]{ "ClientCustomer", "Hidden", "Level", "TimeZone", "TestAccount", "Manager", "DescriptiveName", "CurrencyCode", "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between the given customer and a client customer. CustomerClients only
  /// exist for manager customers. All direct and indirect client customers are
  /// included, as well as the manager itself.
  /// </summary>
  public sealed partial class CustomerClient : pb::IMessage<CustomerClient>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerClient> _parser = new pb::MessageParser<CustomerClient>(() => new CustomerClient());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.CustomerClientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerClient(CustomerClient other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      clientCustomer_ = other.clientCustomer_;
      hidden_ = other.hidden_;
      level_ = other.level_;
      timeZone_ = other.timeZone_;
      testAccount_ = other.testAccount_;
      manager_ = other.manager_;
      descriptiveName_ = other.descriptiveName_;
      currencyCode_ = other.currencyCode_;
      id_ = other.id_;
      appliedLabels_ = other.appliedLabels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerClient Clone() {
      return new CustomerClient(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the customer client.
    /// CustomerClient resource names have the form:
    /// `customers/{customer_id}/customerClients/{client_customer_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_customer" field.</summary>
    public const int ClientCustomerFieldNumber = 12;
    private string clientCustomer_;
    /// <summary>
    /// Output only. The resource name of the client-customer which is linked to
    /// the given customer. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientCustomer {
      get { return clientCustomer_ ?? ""; }
      set {
        clientCustomer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "client_customer" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasClientCustomer {
      get { return clientCustomer_ != null; }
    }
    /// <summary>Clears the value of the "client_customer" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearClientCustomer() {
      clientCustomer_ = null;
    }

    /// <summary>Field number for the "hidden" field.</summary>
    public const int HiddenFieldNumber = 13;
    private bool hidden_;
    /// <summary>
    /// Output only. Specifies whether this is a
    /// [hidden account](https://support.google.com/google-ads/answer/7519830).
    /// Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Hidden {
      get { if ((_hasBits0 & 1) != 0) { return hidden_; } else { return false; } }
      set {
        _hasBits0 |= 1;
        hidden_ = value;
      }
    }
    /// <summary>Gets whether the "hidden" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHidden {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "hidden" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHidden() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 14;
    private long level_;
    /// <summary>
    /// Output only. Distance between given customer and client. For self link, the level value
    /// will be 0. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Level {
      get { if ((_hasBits0 & 2) != 0) { return level_; } else { return 0L; } }
      set {
        _hasBits0 |= 2;
        level_ = value;
      }
    }
    /// <summary>Gets whether the "level" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLevel {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "level" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLevel() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "time_zone" field.</summary>
    public const int TimeZoneFieldNumber = 15;
    private string timeZone_;
    /// <summary>
    /// Output only. Common Locale Data Repository (CLDR) string representation of the
    /// time zone of the client, e.g. America/Los_Angeles. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TimeZone {
      get { return timeZone_ ?? ""; }
      set {
        timeZone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "time_zone" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTimeZone {
      get { return timeZone_ != null; }
    }
    /// <summary>Clears the value of the "time_zone" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTimeZone() {
      timeZone_ = null;
    }

    /// <summary>Field number for the "test_account" field.</summary>
    public const int TestAccountFieldNumber = 16;
    private bool testAccount_;
    /// <summary>
    /// Output only. Identifies if the client is a test account. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool TestAccount {
      get { if ((_hasBits0 & 4) != 0) { return testAccount_; } else { return false; } }
      set {
        _hasBits0 |= 4;
        testAccount_ = value;
      }
    }
    /// <summary>Gets whether the "test_account" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTestAccount {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "test_account" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTestAccount() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "manager" field.</summary>
    public const int ManagerFieldNumber = 17;
    private bool manager_;
    /// <summary>
    /// Output only. Identifies if the client is a manager. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Manager {
      get { if ((_hasBits0 & 8) != 0) { return manager_; } else { return false; } }
      set {
        _hasBits0 |= 8;
        manager_ = value;
      }
    }
    /// <summary>Gets whether the "manager" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasManager {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "manager" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearManager() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "descriptive_name" field.</summary>
    public const int DescriptiveNameFieldNumber = 18;
    private string descriptiveName_;
    /// <summary>
    /// Output only. Descriptive name for the client. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DescriptiveName {
      get { return descriptiveName_ ?? ""; }
      set {
        descriptiveName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "descriptive_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDescriptiveName {
      get { return descriptiveName_ != null; }
    }
    /// <summary>Clears the value of the "descriptive_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDescriptiveName() {
      descriptiveName_ = null;
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 19;
    private string currencyCode_;
    /// <summary>
    /// Output only. Currency code (e.g. 'USD', 'EUR') for the client. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CurrencyCode {
      get { return currencyCode_ ?? ""; }
      set {
        currencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "currency_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCurrencyCode {
      get { return currencyCode_ != null; }
    }
    /// <summary>Clears the value of the "currency_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCurrencyCode() {
      currencyCode_ = null;
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 20;
    private long id_;
    /// <summary>
    /// Output only. The ID of the client customer. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 16) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 16;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 16) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~16;
    }

    /// <summary>Field number for the "applied_labels" field.</summary>
    public const int AppliedLabelsFieldNumber = 21;
    private static readonly pb::FieldCodec<string> _repeated_appliedLabels_codec
        = pb::FieldCodec.ForString(170);
    private readonly pbc::RepeatedField<string> appliedLabels_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The resource names of the labels owned by the requesting customer that are
    /// applied to the client customer.
    /// Label resource names have the form:
    ///
    /// `customers/{customer_id}/labels/{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> AppliedLabels {
      get { return appliedLabels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerClient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ClientCustomer != other.ClientCustomer) return false;
      if (Hidden != other.Hidden) return false;
      if (Level != other.Level) return false;
      if (TimeZone != other.TimeZone) return false;
      if (TestAccount != other.TestAccount) return false;
      if (Manager != other.Manager) return false;
      if (DescriptiveName != other.DescriptiveName) return false;
      if (CurrencyCode != other.CurrencyCode) return false;
      if (Id != other.Id) return false;
      if(!appliedLabels_.Equals(other.appliedLabels_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasClientCustomer) hash ^= ClientCustomer.GetHashCode();
      if (HasHidden) hash ^= Hidden.GetHashCode();
      if (HasLevel) hash ^= Level.GetHashCode();
      if (HasTimeZone) hash ^= TimeZone.GetHashCode();
      if (HasTestAccount) hash ^= TestAccount.GetHashCode();
      if (HasManager) hash ^= Manager.GetHashCode();
      if (HasDescriptiveName) hash ^= DescriptiveName.GetHashCode();
      if (HasCurrencyCode) hash ^= CurrencyCode.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      hash ^= appliedLabels_.GetHashCode();
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
      if (HasClientCustomer) {
        output.WriteRawTag(98);
        output.WriteString(ClientCustomer);
      }
      if (HasHidden) {
        output.WriteRawTag(104);
        output.WriteBool(Hidden);
      }
      if (HasLevel) {
        output.WriteRawTag(112);
        output.WriteInt64(Level);
      }
      if (HasTimeZone) {
        output.WriteRawTag(122);
        output.WriteString(TimeZone);
      }
      if (HasTestAccount) {
        output.WriteRawTag(128, 1);
        output.WriteBool(TestAccount);
      }
      if (HasManager) {
        output.WriteRawTag(136, 1);
        output.WriteBool(Manager);
      }
      if (HasDescriptiveName) {
        output.WriteRawTag(146, 1);
        output.WriteString(DescriptiveName);
      }
      if (HasCurrencyCode) {
        output.WriteRawTag(154, 1);
        output.WriteString(CurrencyCode);
      }
      if (HasId) {
        output.WriteRawTag(160, 1);
        output.WriteInt64(Id);
      }
      appliedLabels_.WriteTo(output, _repeated_appliedLabels_codec);
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
      if (HasClientCustomer) {
        output.WriteRawTag(98);
        output.WriteString(ClientCustomer);
      }
      if (HasHidden) {
        output.WriteRawTag(104);
        output.WriteBool(Hidden);
      }
      if (HasLevel) {
        output.WriteRawTag(112);
        output.WriteInt64(Level);
      }
      if (HasTimeZone) {
        output.WriteRawTag(122);
        output.WriteString(TimeZone);
      }
      if (HasTestAccount) {
        output.WriteRawTag(128, 1);
        output.WriteBool(TestAccount);
      }
      if (HasManager) {
        output.WriteRawTag(136, 1);
        output.WriteBool(Manager);
      }
      if (HasDescriptiveName) {
        output.WriteRawTag(146, 1);
        output.WriteString(DescriptiveName);
      }
      if (HasCurrencyCode) {
        output.WriteRawTag(154, 1);
        output.WriteString(CurrencyCode);
      }
      if (HasId) {
        output.WriteRawTag(160, 1);
        output.WriteInt64(Id);
      }
      appliedLabels_.WriteTo(ref output, _repeated_appliedLabels_codec);
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
      if (HasClientCustomer) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientCustomer);
      }
      if (HasHidden) {
        size += 1 + 1;
      }
      if (HasLevel) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Level);
      }
      if (HasTimeZone) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeZone);
      }
      if (HasTestAccount) {
        size += 2 + 1;
      }
      if (HasManager) {
        size += 2 + 1;
      }
      if (HasDescriptiveName) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(DescriptiveName);
      }
      if (HasCurrencyCode) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(CurrencyCode);
      }
      if (HasId) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      size += appliedLabels_.CalculateSize(_repeated_appliedLabels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerClient other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasClientCustomer) {
        ClientCustomer = other.ClientCustomer;
      }
      if (other.HasHidden) {
        Hidden = other.Hidden;
      }
      if (other.HasLevel) {
        Level = other.Level;
      }
      if (other.HasTimeZone) {
        TimeZone = other.TimeZone;
      }
      if (other.HasTestAccount) {
        TestAccount = other.TestAccount;
      }
      if (other.HasManager) {
        Manager = other.Manager;
      }
      if (other.HasDescriptiveName) {
        DescriptiveName = other.DescriptiveName;
      }
      if (other.HasCurrencyCode) {
        CurrencyCode = other.CurrencyCode;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      appliedLabels_.Add(other.appliedLabels_);
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
          case 98: {
            ClientCustomer = input.ReadString();
            break;
          }
          case 104: {
            Hidden = input.ReadBool();
            break;
          }
          case 112: {
            Level = input.ReadInt64();
            break;
          }
          case 122: {
            TimeZone = input.ReadString();
            break;
          }
          case 128: {
            TestAccount = input.ReadBool();
            break;
          }
          case 136: {
            Manager = input.ReadBool();
            break;
          }
          case 146: {
            DescriptiveName = input.ReadString();
            break;
          }
          case 154: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 160: {
            Id = input.ReadInt64();
            break;
          }
          case 170: {
            appliedLabels_.AddEntriesFrom(input, _repeated_appliedLabels_codec);
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
          case 98: {
            ClientCustomer = input.ReadString();
            break;
          }
          case 104: {
            Hidden = input.ReadBool();
            break;
          }
          case 112: {
            Level = input.ReadInt64();
            break;
          }
          case 122: {
            TimeZone = input.ReadString();
            break;
          }
          case 128: {
            TestAccount = input.ReadBool();
            break;
          }
          case 136: {
            Manager = input.ReadBool();
            break;
          }
          case 146: {
            DescriptiveName = input.ReadString();
            break;
          }
          case 154: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 160: {
            Id = input.ReadInt64();
            break;
          }
          case 170: {
            appliedLabels_.AddEntriesFrom(ref input, _repeated_appliedLabels_codec);
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

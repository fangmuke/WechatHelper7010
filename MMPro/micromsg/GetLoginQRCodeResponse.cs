using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "GetLoginQRCodeResponse")]
	[Serializable]
	public class GetLoginQRCodeResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private SKBuiltinBuffer_t _QRCode;

		private string _UUID = "";

		private uint _CheckTime;

		private SKBuiltinBuffer_t _NotifyKey;

		private uint _ExpiredTime = 0u;

		private string _BlueToothBroadCastUUID = "";

		private SKBuiltinBuffer_t _BlueToothBroadCastContent = null;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "QRCode", DataFormat = DataFormat.Default)]
		public SKBuiltinBuffer_t QRCode
		{
			get
			{
				return this._QRCode;
			}
			set
			{
				this._QRCode = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "UUID", DataFormat = DataFormat.Default), DefaultValue("")]
		public string UUID
		{
			get
			{
				return this._UUID;
			}
			set
			{
				this._UUID = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "CheckTime", DataFormat = DataFormat.TwosComplement)]
		public uint CheckTime
		{
			get
			{
				return this._CheckTime;
			}
			set
			{
				this._CheckTime = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "NotifyKey", DataFormat = DataFormat.Default)]
		public SKBuiltinBuffer_t NotifyKey
		{
			get
			{
				return this._NotifyKey;
			}
			set
			{
				this._NotifyKey = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "ExpiredTime", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint ExpiredTime
		{
			get
			{
				return this._ExpiredTime;
			}
			set
			{
				this._ExpiredTime = value;
			}
		}

		[ProtoMember(7, IsRequired = false, Name = "BlueToothBroadCastUUID", DataFormat = DataFormat.Default), DefaultValue("")]
		public string BlueToothBroadCastUUID
		{
			get
			{
				return this._BlueToothBroadCastUUID;
			}
			set
			{
				this._BlueToothBroadCastUUID = value;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "BlueToothBroadCastContent", DataFormat = DataFormat.Default), DefaultValue(null)]
		public SKBuiltinBuffer_t BlueToothBroadCastContent
		{
			get
			{
				return this._BlueToothBroadCastContent;
			}
			set
			{
				this._BlueToothBroadCastContent = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}

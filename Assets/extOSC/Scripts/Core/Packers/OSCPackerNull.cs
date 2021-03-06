/* Copyright (c) 2019 ExT (V.Sigalkin) */

namespace extOSC.Core.Packers
{
    internal class OSCPackerNull : OSCPacker<object>
    {
        #region Public Methods

        public override OSCValueType GetPackerType()
        {
            return OSCValueType.Null;
        }

        #endregion

        #region Protected Methods

        protected override object BytesToValue(byte[] buffer, ref int index)
        {
            return null;
        }

        protected override void ValueToBytes(byte[] buffer, ref int index, object value)
        { }

        #endregion
    }
}
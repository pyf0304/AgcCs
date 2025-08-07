using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgcMvc.FunClass
{
    public sealed class Option<T>
    {
        private readonly T value;
        public T Value
        {
            get
            {
                return value;
            }
        }

        private readonly bool hasValue;
        public bool HasValue { get { return hasValue; } }
        public bool IsSome { get { return hasValue; } }
        public bool IsNone { get { return !hasValue; } }

        public Option(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        private Option() { }
        public static readonly Option<T> None = new Option<T>();

        public static Option<T> Some<T>(T value)
        {
            return new Option<T>(value);
        }
        public static bool operator ==(Option<T> a, Option<T> b)
        {
            return a.HasValue == b.HasValue && EqualityComparer<T>.Default.Equals(a.Value, b.Value);
        }
        public static bool operator !=(Option<T> a, Option<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            int hashCode = hasValue.GetHashCode();
            if (hasValue)
                hashCode ^= value.GetHashCode();
            return hashCode;
        }


        //public static readonly Option None = new Option();

        //public static implicit operator Option<T>(Option option)
        //{
        //    return Option<T>.None;
        //}

    }
}
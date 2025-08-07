using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{

    public static class F
    {
       
        public static Option.Some<T> Some<T>(T value)
            => new Option.Some<T>(value);

        public static Option.None None
            => Option.None.Default;
    }
    namespace Option
    {
        public struct None
        {
            internal static readonly None Default = new None();
        }
        public struct Some<T>
        {
            internal T Value { get; }
            internal Some(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                Value = value;
            }
        }
    }


    /// <summary>
    /// 专用于函数式编程之可选值
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
        /// <summary>
        /// 是否有值
        /// </summary>
        public bool HasValue { get { return hasValue; } }
        /// <summary>
        /// 是否Some
        /// </summary>
        public bool IsSome { get { return hasValue; } }
        /// <summary>
        /// 是否无值
        /// </summary>
        public bool IsNone { get { return !hasValue; } }

        public Option(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        //public static readonly Option None = new Option();

        public static implicit operator Option<T>(Option.None _)
            => new Option<T>();

        public static implicit operator Option<T>(Option.Some<T> some)
              => new Option<T>(some.Value);

        public static implicit operator Option<T>(T value)
              => value == null ? None : Some(value);
        /// <summary>
        /// 匹配函数
        /// </summary>
        /// <typeparam name="R"></typeparam>
        /// <param name="None"></param>
        /// <param name="Some"></param>
        /// <returns></returns>
        public R Match<R>(Func<R> None, Func<T, R> Some)
            => IsSome ? Some(value) : None();

        /// <summary>
        /// 比较算子==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Option<T> a, Option<T> b)
        {
            return a.HasValue == b.HasValue && EqualityComparer<T>.Default.Equals(a.Value, b.Value);
        }
        /// <summary>
        /// 比较算子 !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Option<T> a, Option<T> b)
        {
            return !(a == b);
        }


        private Option() { }
        public static readonly Option<T> None = new Option<T>();

        public static Option<T> Some<T>(T value)
            => new Option<T>(value);



        public override int GetHashCode()
        {
            int hashCode = hasValue.GetHashCode();
            if (hasValue)
                hashCode ^= value.GetHashCode();
            return hashCode;
        }

    }
}

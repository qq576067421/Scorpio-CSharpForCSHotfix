using Scorpio.Compile.Compiler;
namespace Scorpio.Compile.CodeDom {
    //θ΅εΌει = += -= /= *= %= |= &= ^= >>= <<=
    public class CodeAssign : CodeObject {
        public CodeMember member;
        public CodeObject value;
        public TokenType AssignType;
        public CodeAssign(CodeMember member, CodeObject value, TokenType assignType, int line) : base(line) {
            this.member = member;
            this.value = value;
            this.AssignType = assignType;
        }
        public override string ToString() {
            return $"{member} => {value}  {this.AssignType}";
        }
    }
}

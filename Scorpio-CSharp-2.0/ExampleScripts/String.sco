//`` 、“”、 ‘’ 都可以申请String, ``内可以直接使用” ‘,不用转译, 其他同理
str1 = "123‘12`3"
str2 = '123"12`3'
str3 = `123"12'3`
str4 = @"1111
2222222
333333
4444444"
//字符串内部可以使用 ${} 替换成变量
str5 = @'1111
${str1}
333333
4444444'
str6 = @`111
222
333
444`
for (var i = 1, 6) {
    print(_G["str${i}"])
}
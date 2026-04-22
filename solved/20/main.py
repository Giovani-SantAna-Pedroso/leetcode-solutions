def isValid(s):
        opened = []
        # print(s, ' -> ', end="")
        try:
            for i in s:
                if i in "([{":
                    opened.append(i)
                else:
                    if i == ")":
                        if opened[-1] != "(":
                            return False
                        opened.pop()
                    if i == "]":
                        if opened[-1] != "[":
                            return False
                        opened.pop()
                    if i == "}":
                        if opened[-1] != "{":
                            return False
                        opened.pop()

            return len(opened) == 0
        except Exception as e:
            return False

ex1="()"
print(isValid(ex1))

ex1="()[]{}"
print(isValid(ex1))

ex1="(]"
print( isValid(ex1))


ex1="([])"
print( isValid(ex1))


ex1="([)]"
print( isValid(ex1))

def main() -> object:
  text = "aabbbccdddddffcccghhiicc012345ccc6789aaaeeea"
  result = ''
  result = maxOccurrenceInText(text)
  print(result)


def maxOccurrenceInText(text) -> str:
  text_list = []
  text_list = list(set(text))
  text_list.sort()
  text_len = len(text_list)
  max_token = ''
  list_of_tokens = []
  list_of_chars = []
  token_string = ''
  cur_char = text[0]
  last_char = ''
  max_ocurr = 0
  max_ocurr_index = 0
  for i in range(0, text_len):
    if cur_char == text[i]:
      list_of_chars.append(cur_char)
    else:
      token_string = ''.join(list_of_chars)
      list_of_tokens.append(token_string)
      list_of_chars.clear()
      last_char = cur_char
      cur_char = text[i]
      list_of_chars.append(cur_char)
  if cur_char != last_char:
    token_string = ''.join(list_of_chars)
    list_of_tokens.append(token_string)
  char_in_process = ''
  tot_tokens = len(list_of_tokens)

  for i in range(0, text_len, 1):
    char_in_process = text_list[i]
    counter = 0
    index_in_text_list = i
    for j in range(0, tot_tokens - 1, 1):
      if list_of_tokens[j].find(char_in_process) != -1:
        counter += 1
    if counter > max_ocurr:
      max_ocurr = counter
      max_ocurr_index = i
  max_token = text_list[max_ocurr_index]
  return max_token


if __name__ == '__main__':
  main()

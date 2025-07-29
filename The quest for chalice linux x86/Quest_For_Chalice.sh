#!/bin/sh
echo -ne '\033c\033]0;Quest_For_Chalice\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/Quest_For_Chalice.x86_64" "$@"

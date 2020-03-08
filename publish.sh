dotnet paket restore
tools/fsformatting.exe literate --processDirectory --inputDirectory "code" --outputDirectory "_posts"

git add --all .
git commit -a -m "${1}"

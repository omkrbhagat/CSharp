
%.exe: %.cs
	ni -Path .\PlayGround\Program.cs
	Add-Content -Path .\PlayGround\Program.cs -Value (Get-Content -Path $<)
	dotnet run .\PlayGround\Program.cs -o $@

.PHONY: clean
clean:
	del *.exe .CSharpShellProjData.db
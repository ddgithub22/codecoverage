param (
    [string]$file
 )
 
((Get-Content "$file") -join "`n").Replace("<script", "<!-- script").Replace("</script>", "</script -->") | Set-Content "$file"
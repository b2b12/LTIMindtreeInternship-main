select count(number_of_members) as project_count
from project
where number_of_members>10

select batch,count(*) as male_alumni_count
from profile
where gender='Male'
group by batch

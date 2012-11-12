class Lion
  string type
end

class Duck
  string type
end

def MakeLionRoar lion
  #some code to make lion roar
end

def MakeDuckQuack duck
  #some code to make duck quack
end

def MakeAllAnimalsMakeNoise list_of_animals
  list_of_animals.each do |animal|
    if (animal.type == "Lion")
      MakeLionRoar animal
    elsif (animal.type == "Duck")
      MakeDuckQuack animal
    end
  end

end
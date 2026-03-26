// Fill out your copyright notice in the Description page of Project Settings.

#include "MovingPlatform.h"

// Sets default values
AMovingPlatform::AMovingPlatform() {
  // Set this actor to call Tick() every frame.  You can turn this off to
  // improve performance if you don't need it.
  PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void AMovingPlatform::BeginPlay() {
  Super::BeginPlay();

  LogStart("Hallowed be thy name !");
}

// Called every frame
void AMovingPlatform::Tick(float DeltaTime) {
  Super::Tick(DeltaTime);

  FVector CurrentLocation = GetActorLocation();

  CurrentLocation = CurrentLocation + (PlatformVelocity * DeltaTime);

  SetActorLocation(CurrentLocation);
}

void AMovingPlatform::LogStart(FString Message) {
  UE_LOG(LogTemp, Error, TEXT("%s"), *Message);
}